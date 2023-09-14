package com.ppp.sunmiimplementationprinterv2;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.LinearLayoutCompat;

import android.content.Context;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Matrix;
import android.graphics.Paint;
import android.graphics.Rect;
import android.graphics.Typeface;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.util.Log;
import android.util.TypedValue;
import android.util.Xml;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TextView;

import com.ppp.sunmit2printer.utils.*;

import java.nio.ByteBuffer;
import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

import kotlin.text._OneToManyTitlecaseMappingsKt;

public class MainActivity extends AppCompatActivity {

    private SunmiPrintHelper _sunmiPrinterHelper = SunmiPrintHelper.getInstance();
    private Context _mContext;

    private EditText _editTxtPosition;
    private EditText _editTxtPContent;
    private Button _btnTestPosition;
    private EditText _fontSizeSetting;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        _mContext = this.getApplicationContext();

        SunmiPrintHelper.getInstance().initSunmiPrinterService(_mContext);
        //_sunmiPrinterHelper.initSunmiPrinterService(_mContext);
        _editTxtPosition = findViewById(R.id.hexPositionTxt);
        _editTxtPContent = findViewById(R.id.txtContent);
        _btnTestPosition = findViewById(R.id.buttonTestPrintPosition);
        _fontSizeSetting = findViewById(R.id.fontSizeTxtI);

        Button buttonTestPrint = findViewById(R.id.buttonTestPrint);
        buttonTestPrint.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Perform actions when the button is clicked
                testPrinter();
            }
        });

        _btnTestPosition.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                printPositionT();
            }
        });
    }

    private void printPositionT() {

        _sunmiPrinterHelper.initSunmiPrinterService(_mContext);
        _sunmiPrinterHelper.initPrinter();
        int finalVaulePosition = Integer.parseInt(_editTxtPosition.getText().toString());
        int fontSizeValue = Integer.parseInt(_fontSizeSetting.getText().toString());
        byte[] sAbPositionRt = {0x1B, 0x24};
        //byte[] sAbPositionRt = {0x1B, 0x5c};

        byte[] position1st = {(byte) finalVaulePosition, 0x01};
        byte[] st1 = concateByteArr(sAbPositionRt, position1st);
        byte[] stLast = {(byte) 0x64, 0x01}; // 100 + 256
        byte[] st2 = concateByteArr(sAbPositionRt, stLast);
        _sunmiPrinterHelper.sendRawData(st1);
        String a = _editTxtPContent.getText().toString();
        _sunmiPrinterHelper.printText(a + "\n", fontSizeValue, false, false, null);
        //_sunmiPrinterHelper.printText("120.00" + "\n", 20, false, false, null);
        _sunmiPrinterHelper.cutpaper();
    }

    private void testPrinter() {
        Log.d("F", _mContext.toString());
        LinearLayout linearView = findViewById(R.id.linearLayoutMain);
        int height = 300;
        int width = linearView.getWidth();
        Bitmap layouPrint = getLayoutBitmap(linearView, height, width);
        Bitmap linearLayoutPrint = getLinearLayoutBitmapFull(linearView);
        _sunmiPrinterHelper.initSunmiPrinterService(_mContext);
        _sunmiPrinterHelper.initPrinter();
        //_sunmiPrinterHelper.printText("HI\n", 18 , false, false, null);

        Bitmap resizedLayoutPrint = resizeImage(layouPrint, 72 * 8, height);
        Bitmap textImage = generateImageFromString("สวัสดี", 200, 400);

        Bitmap cropImage = getCroppedLayoutBitmap(linearView);

        Bitmap originalBitmap = layouPrint;
        int targetWidth = 576; // 48mm printing zone with 203dpi => 383px
        Bitmap rescaledBitmap = Bitmap.createScaledBitmap(
                originalBitmap,
                targetWidth,
                Math.round(((float) originalBitmap.getHeight()) * ((float) targetWidth) / ((float) originalBitmap.getWidth())),
                true
        );
        Bitmap createUIBM = createUI(_mContext);
        //_sunmiPrinterHelper.printBitmapBlackAndWhite(layouPrint, 0);
        //_sunmiPrinterHelper.printBitmap(layouPrint, 0);

        //Bitmap nativeUIExample = createUIExample(_mContext);
        //_sunmiPrinterHelper.printBitmap(linearLayoutPrint, 0);

        //byte[] multipleLineBytes = { 0x1C, 0x26, 0x1C, 0x43, (byte)0xFF };
        //_sunmiPrinterHelper.sendRawData();
        //_sunmiPrinterHelper.printBitmap(layouPrint, 0);
        //String contentTest = "สวัสดีนี่คือภาษาไทย";
        //byte[] contentBytes = contentTest.getBytes(StandardCharsets.UTF_8);

        //byte[] dataPrintEncoded = encodeDescription(contentTest);
        //_sunmiPrinterHelper.sendRawData(dataPrintEncoded);

        String thSt = "รวมทั้งสิ้น";
        String thSt2 = "ค่าบริการ";
        String thSt3 = "ภาษีมูลค่าเพิ่ม";

        String r1 = padLine(thSt, "120.00", 42);
        String r2 = padLine(thSt2, "12.00", 42);
        String r3 = padLine(thSt3, "1.00", 42);

        /*
        _sunmiPrinterHelper.printText(r1, 20, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r2, 20, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r3, 20, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);

        _sunmiPrinterHelper.printText(r1, 21, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r2, 21, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r3, 21, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);


        _sunmiPrinterHelper.printText(r1, 22, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r2, 22, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r3, 22, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);

        _sunmiPrinterHelper.printText(r1, 23, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r2, 23, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r3, 23, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);

        _sunmiPrinterHelper.printText(r1, 24, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r2, 24, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r3, 24, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);

        _sunmiPrinterHelper.printText(r1, 25, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r2, 25, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(r3, 25, false , false, null);
        _sunmiPrinterHelper.sunmiLineWrap(1);
         */

        /*
        String tcv1 = textConvert42(thSt, "120.00", 5);
        String tcv2 = textConvert42(thSt2, "12.00", 5);
        String tcv3 = textConvert42(thSt3, "1.00", 5);

        byte[] e = {0x1C, 0x26};
        byte[] utf8e = {0x1C, 0x43, (byte) 0xFF};
        _sunmiPrinterHelper.sendRawData(e);
        _sunmiPrinterHelper.sendRawData(utf8e);
        String utcv1 = new String(tcv1.getBytes(), Charset.forName("UTF-8"));
        String utcv2 = new String(tcv2.getBytes(), Charset.forName("UTF-8"));
        String utcv3 = new String(tcv3.getBytes(), Charset.forName("UTF-8"));
        _sunmiPrinterHelper.printText(utcv1, 25, false , false, "utf-8");
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(utcv2, 25, false , false, "utf-8");
        _sunmiPrinterHelper.sunmiLineWrap(1);
        _sunmiPrinterHelper.printText(utcv3, 25, false , false,"utf-8");
        _sunmiPrinterHelper.sunmiLineWrap(1);
     */
       // Print Zone
        int spaceLength = 42;
        int remainSpace1 = spaceLength - 20;
        StringBuilder stringBuilder = new StringBuilder();
        if (thSt3.length() != remainSpace1) {
            stringBuilder.append(thSt3);
            if(stringBuilder.length() != remainSpace1) {
                String spaces = new String(new char[remainSpace1 - stringBuilder.length()]).replace('\0', 'x');
                stringBuilder.append(spaces);
            }
        }

        //_sunmiPrinterHelper.printText(stringBuilder.toString(), 25, false, false, null);
        //_sunmiPrinterHelper.printText(stringBuilder.toString(), 25, false, false, null);
        //_sunmiPrinterHelper.printText("120.00", 25, false, false, null);
        //_sunmiPrinterHelper.sunmiLineWrap(1);

        byte[] sAbPosition = {0x1B, 0x24, 0x00, };
        byte[] sAbPositionRt = {0x1B, 0x24};
        //byte[] sAbPositionRt = {0x1B, 0x5c};

        byte[] position1st = {0x00, 0x00};
        byte[] st1 = concateByteArr(sAbPositionRt, position1st);
        Charset charset = Charset.forName("TIS620");
        //byte[] sthBArr1 = charset.encode(thSt).array();
        byte[] sthBArr1 = thSt.getBytes(charset);
        byte[] msgHeader1 = concateByteArr(st1, sthBArr1);
        //_sunmiPrinterHelper.sendRawData(new byte[]{0x1b, 0x4d, 0x19});
        byte[] stLast = {(byte) 0x64, 0x01}; // 100 + 256
        byte[] st2 = concateByteArr(sAbPositionRt, stLast);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt, 20, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("120.00" + "\n", 20, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt2, 20, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("12.00" + "\n", 20, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt3, 20, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("1.00" + "\n", 20, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt, 21, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("120.00" + "\n", 21, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt2, 21, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("12.00" + "\n", 21, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt3, 21, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("1.00" + "\n", 21, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt, 22, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("120.00" + "\n", 22, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt2, 22, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("12.00" + "\n", 22, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt3, 22, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("1.00" + "\n", 22, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt, 23, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("120.00" + "\n", 23, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt2, 23, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("12.00" + "\n", 23, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt3, 23, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("1.00" + "\n", 23, false, false, null);


        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt, 24, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("120.00" + "\n", 24, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt2, 24, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("12.00" + "\n", 24, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt3, 24, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("1.00" + "\n", 24, false, false, null);


        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt, 25, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("120.00" + "\n", 25, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt2, 25, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("12.00" + "\n", 25, false, false, null);

        _sunmiPrinterHelper.sendRawData(st1);
        _sunmiPrinterHelper.printText(thSt3, 25, false, false, null);
        _sunmiPrinterHelper.sendRawData(st2);
        _sunmiPrinterHelper.printText("1.00" + "\n", 25, false, false, null);
        _sunmiPrinterHelper.cutpaper();




    }

    private byte[] concateByteArr(byte[] first, byte[] second) {
        byte[] newArr = new byte[first.length + second.length];
        System.arraycopy(first, 0, newArr, 0, first.length);
        System.arraycopy(second, 0, newArr, first.length, second.length);
        return newArr;
    }
    /** utility: pads two strings to columns per line */
    protected String padLine(@Nullable String partOne, @Nullable String partTwo, int columnsPerLine){
        if(partOne == null) {partOne = "";}
        if(partTwo == null) {partTwo = "";}
        String concat;
        if((partOne.length() + partTwo.length()) > columnsPerLine) {
            concat = partOne + " " + partTwo;
        } else {
            int padding = columnsPerLine - (partOne.length() + partTwo.length());
            concat = partOne + repeat(" ", padding) + partTwo;
        }
        return concat;
    }

    /** utility: string repeat */
    protected String repeat(String str, int i){
        return new String(new char[i]).replace("\0", str);
    }
    public String textConvert42(String left, String right, int gap) {
        int total = 42;

        // This is to give a gap between the 2 columns
        for (int i = 0; i < gap; i++) {
            right = " " + right;
        }

        // This will make sure that the right string is pushed to the right.
        // If the total sum of both the strings is less than the total length(42),
        // we are prepending extra spaces to the RIGHT string so that it is pushed to the right.
        if ((left.length() + right.length()) < total) {
            int extraSpace = total - left.length() - right.length();
            for (int i = 0; i < extraSpace; i++) {
                left = left + " ";
            }
        }

        int printableSpace = total - right.length(); // printable space left for the LEFT string

        // stringBuilder -> is the modified string which has RIGHT inserted in the LEFT at the appropriate position. And also contains the new line. This is the string which needs to be printed
        StringBuilder stringBuilder = new StringBuilder();

        // Below 2 statements make the first line of the print
        stringBuilder.append(left.substring(0, Math.min(printableSpace, left.length())));
        stringBuilder.append(right);

        // stringBuilder now contains the first line of the print

        // For appropriately printing the remaining lines of the LEFT string
        for (int index = printableSpace; index < left.length(); index = index + (printableSpace)) {
            stringBuilder.append(left.substring(index, Math.min(index + printableSpace, left.length())) + "\n");
        }

        // epsonPrinter.addText(stringBuilder.toString());
        //_sunmiPrinterHelper.printText();
        return stringBuilder.toString();
    }
    public Bitmap createUIExample(Context context) {
        LinearLayout linearLayoutMain = new LinearLayout(context);
        linearLayoutMain.setLayoutParams(new LinearLayoutCompat.LayoutParams(LinearLayoutCompat.LayoutParams.MATCH_PARENT, LinearLayoutCompat.LayoutParams.MATCH_PARENT));
        linearLayoutMain.setOrientation(LinearLayout.VERTICAL);
        linearLayoutMain.setBackgroundColor(Color.WHITE);
        setContentView(linearLayoutMain);
        TextView textView = new TextView(context);
        textView.setText("HIII นี่คือภาษาไทย -");
        textView.setTextColor(Color.BLACK);
        linearLayoutMain.addView(textView);
        Bitmap bmp = getLayoutBitmap(linearLayoutMain, linearLayoutMain.getHeight(), linearLayoutMain.getWidth());
        return bmp;
    }
    public static Bitmap getCroppedLayoutBitmap(LinearLayout linearLayout) {
        // Calculate the desired width and height for cropping
        int desiredWidth = dpToPixels(200); // Convert 200dp to pixels
        int desiredHeight = linearLayout.getHeight(); // Use the original height

        Bitmap bitmap = Bitmap.createBitmap(desiredWidth, desiredHeight, Bitmap.Config.ARGB_8888);
        Canvas canvas = new Canvas(bitmap);
        canvas.drawColor(Color.WHITE); // Set background color

        // Create a rect for cropping
        Rect srcRect = new Rect(0, 0, desiredWidth, desiredHeight);
        Rect destRect = new Rect(0, 0, desiredWidth, desiredHeight);

        linearLayout.draw(canvas); // Draw the layout
        Bitmap croppedBitmap = Bitmap.createBitmap(bitmap, srcRect.left, srcRect.top, srcRect.width(), srcRect.height(), null, false);

        return croppedBitmap;
    }

    private static int dpToPixels(int dp) {
        float density = Resources.getSystem().getDisplayMetrics().density;
        return Math.round(dp * density);
    }
    public Bitmap generateImageFromString(String text, int width, int height) {
        Bitmap imageBitmap = Bitmap.createBitmap(width, height, Bitmap.Config.ARGB_8888);
        Canvas canvas = new Canvas(imageBitmap);
        canvas.drawColor(Color.WHITE); // Set background color

        Paint paint = new Paint();
        paint.setColor(Color.BLACK);
        paint.setTextSize(20);
        //Typeface typeface = Typeface.createFromAsset(getAssets(), "notosansthai_regular.ttf");
        paint.setTypeface(Typeface.MONOSPACE);

        Rect bounds = new Rect();
        paint.getTextBounds(text, 0, text.length(), bounds);

        int x = (width - bounds.width()) / 2;
        int y = (height - bounds.height()) / 2;

        canvas.drawText(text, x, y, paint);

        return imageBitmap;
    }
    private float calculateScalingFactor(int originalWidth, int printerDPI) {
        // Calculate the scaling factor based on printer's DPI and 80mm paper width
        float paperWidthInches = 80f / 25.4f;
        return paperWidthInches * printerDPI / originalWidth;
    }
    private Bitmap getLayoutBitmap(View view, int h, int w) {
        Bitmap returnedBitmap = Bitmap.createBitmap(h, w, Bitmap.Config.ARGB_8888);
        Canvas canvas = new Canvas(returnedBitmap);
        Drawable bgDrawable = view.getBackground();
        if (bgDrawable != null) {
            bgDrawable.draw(canvas);
        } else {
            canvas.drawColor(Color.WHITE);
        }
        view.draw(canvas);
        return returnedBitmap;
    }

    public static Bitmap getLinearLayoutBitmapFull(LinearLayout linearLayout) {
        int width = linearLayout.getWidth();
        // set fake height
        int height = 320;
        //int height = linearLayout.getHeight();

        Bitmap bitmap = Bitmap.createBitmap(width, height, Bitmap.Config.ARGB_8888);
        Canvas canvas = new Canvas(bitmap);
        Drawable bgDrawable = linearLayout.getBackground();
        if (bgDrawable != null) {
            bgDrawable.draw(canvas);
        } else {
            canvas.drawColor(Color.WHITE);
        }

        linearLayout.draw(canvas);

        return bitmap;
    }
    public static Bitmap resizeImage(Bitmap originalBitmap, int newWidth, int newHeight) {
        int width = originalBitmap.getWidth();
        int height = originalBitmap.getHeight();

        float scaleWidth = ((float) newWidth) / width;
        float scaleHeight = ((float) newHeight) / height;

        Matrix matrix = new Matrix();
        matrix.postScale(scaleWidth, scaleHeight);

        return Bitmap.createBitmap(originalBitmap, 0, 0, width, height, matrix, true);
    }
    public static byte[] encodeDescription(String description) {
        List<Byte> byteList = new ArrayList<>();

        byteList.add((byte) 0x1C);
        byteList.add((byte) 0x26);
        byteList.add((byte) 0x1C);
        byteList.add((byte) 0x43);
        byteList.add((byte) 0xFF);

        byte[] encodedStr = description.getBytes(StandardCharsets.UTF_8);

        for (byte b : encodedStr) {
            byteList.add(b);
        }

        byte[] bytes = new byte[byteList.size()];
        for (int i = 0; i < byteList.size(); i++) {
            bytes[i] = byteList.get(i);
        }

        return bytes;
    }
    private Bitmap createUI(Context context) {
        int w = 576, h = 320;
        Bitmap.Config conf = Bitmap.Config.ARGB_8888; // see other conf types
        Bitmap bmp = Bitmap.createBitmap(w, h, conf); // this creates a MUTABLE bitmap
        Canvas canvas = new Canvas(bmp);
        LinearLayout layout = new LinearLayout(context);
        Drawable bgDrawable = layout.getBackground();
        if (bgDrawable != null) {
            bgDrawable.draw(canvas);
        } else {
            canvas.drawColor(Color.WHITE);
        }
        TextView textView = new TextView(context);
        int padding = 4;
        textView.setPadding(padding, padding, padding, padding);
        textView.setText("HIII");
        textView.setTextColor(Color.BLACK);
        layout.addView(textView);
        textView.setTextSize(TypedValue.COMPLEX_UNIT_PX, 18);
        layout.measure(canvas.getWidth(), canvas.getHeight());
        layout.layout(0,0,canvas.getHeight(), canvas.getWidth());
        layout.draw(canvas);
        return bmp;
    }
}
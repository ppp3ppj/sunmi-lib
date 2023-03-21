## **Example Java Binding to MAUI**
AAR - Use Android Studio - Java

    gradle <lib>:assemble
AAR - get jar library

 In Library Gradle use copyModulesJars and copyBuildDependencies Task

MAUI Binding 
 - create project use template Android Java Library Binding 
 - add aar at Addition or you can create Folder and default set AndroidLibrary
 - Build Project and you will get detail .dll in debug screen and file in bin\Debug

MAUI App

 - Add Reference .dll file to this app 
 - and build project again or rebuild

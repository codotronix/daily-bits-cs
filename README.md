# daily-bits-cs
Small and easy to run C# codes to solve small problems of our daily life. Each code should be contained in its own folder with all the necessary instructions and help documentation.


## Table of contents

1. [File Extension Modifier](#file-extension-modifier)



## 1. File Extension Modifier

#### 1.A. What Does it Do ?
  It takes 3 params (parameters)
  
    1. path to the directory where the target files are
    2. string that the files to target ends with (e.g. ".js" or ".js.txt")
    3. string that will replace param 2 in the target file name


#### 1.B. How to Use ?
  Get the .exe file or compile the .cs file to get the .exe file. Then in your cmd prompt, type
  
  `<path_to_exe> <param_1> <param_2> <param_3>`


#### 1.C. Example
    i) To convert all files that ends with ".js.txt" to ending ".js" inside the folder named "My JS Folder"
      
      `C://extMod.exe "C://My JS Folder" ".js.txt" ".js"`
      
    ii) For convenience, we can also put the .exe file the the same folder of the target files. And after moving to that directory in cmd, we can execute (this time we will convert all ".js" ending to ".js.txt" ending)
      
      `extMod.exe "." ".js" ".js.txt"`

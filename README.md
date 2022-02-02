# ha
Hashes. Prints the Sha1, Sha256, Sha384, and Sha512 for a file. Windows command-line tool.

Build using your favorite version of .net, for example:

    c:\windows\microsoft.net\framework64\v4.0.30319\csc.exe ha.cs /nologo /debug:full /o+
    
Sample usage:

    C:\Users\david\OneDrive\ha>ha ha.cs
    computing hashes for file C:\Users\david\OneDrive\ha\ha.cs
      Sha1:   500a69a0f2dae59d0647d9078bb0be17a5752a5e
      Sha256: d1cbd898f7bc0e50c54a4b7841d9a01ccf4e8acf623cb8166d3bcdbc173084cf
      Sha384: ca6c65a9748c7e23b4916924f3fd60a25d1b248dfc2088cd1e95bb905d80528784395728960caf3ff4ce6ba9d7b00fee
      Sha512: 33d536130f5984d9333cbe2ac03101eab4d3afefa279e02cf0708d2e71d3856a8cdbd456f5c7787d64b3f51deb3022746bb05c9c8535e6b5d399ceb3c2a63f4e
      

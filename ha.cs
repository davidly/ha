using System;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Hashes
{
    static void Usage()
    {
        Console.WriteLine( "Usage: ha filename\n" );
        Environment.Exit( 1 );
    } //Usage

    static string ComputeSha( string fullpath, System.Security.Cryptography.HashAlgorithm ha )
    {
        FileStream fileStream = File.OpenRead( fullpath );
        byte[] bytes = ha.ComputeHash( fileStream );
        fileStream.Close();

        StringBuilder sBuilder = new StringBuilder();

        for ( int i = 0; i < bytes.Length; i++)
            sBuilder.Append( bytes[ i ].ToString( "x2" ) );

        return sBuilder.ToString();
    } //ComputeSha

    static void Main( string[] args )
    {
        if ( 1 != args.Count() )
            Usage();

        try
        {
            string fullpath = Path.GetFullPath( args[0] );

            if ( ! File.Exists( fullpath ) )
                Console.WriteLine( "can't find file {0}", fullpath );
            else
            {
                Console.WriteLine( "computing hashes for file {0}", fullpath );
    
                Console.WriteLine( "  Sha1:   {0}", ComputeSha( fullpath, SHA1.Create() ) );
                Console.WriteLine( "  Sha256: {0}", ComputeSha( fullpath, SHA256.Create() ) );
                Console.WriteLine( "  Sha384: {0}", ComputeSha( fullpath, SHA384.Create() ) );
                Console.WriteLine( "  Sha512: {0}", ComputeSha( fullpath, SHA512.Create() ) );
            }
        }
        catch( Exception ex )
        {
            Console.WriteLine( "failure: " + ex.ToString() );
        }
    } //Main
} //Hashes

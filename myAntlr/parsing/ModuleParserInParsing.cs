﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using myAntlr.misc;

namespace myAntlr.parsing
{
    // To avoid conflict of ModuleParser.cs in obj folder generated by Antlr.
    // Change this class name to ModuleParserInParsing.

    public class ModuleParserInParsing
    {
        ANTLRModuleParserDriver parserDriver = new ANTLRModuleParserDriver();

        public void parseFile(String filename)
        {
            //System.out.println(filename);
            System.Console.WriteLine(filename);
        
            try{
                parserDriver.parseAndWalkFile(filename);
            }catch(ParserException ex){
                // System.err.println("Error parsing file: " + filename);
                System.Console.Error.WriteLine("Error parsing file: " + filename);
            }
        }

        public void parseString(String code)
        {
            try
            {
                parserDriver.parseAndWalkString(code);
            }
            catch (ParserException ex)
            {
                // System.err.println("Error parsing string.");
                System.Console.Error.WriteLine("Error parsing string.");
            }
        }

        public void addObserver(MyObserver anObserver)
        {
            parserDriver.addObserver(anObserver);
        }

        // Not used?
        public void parseListOfFiles(List<String> filenames)
        {
            parserDriver.begin();
        
            // for(String filename : filenames)
            foreach (String filename in filenames)
                parseFile(filename);
        
            parserDriver.end();
        }
    }
}

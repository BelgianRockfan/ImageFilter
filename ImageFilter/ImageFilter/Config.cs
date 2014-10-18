using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilter
{
    public static class Config
    {
        private static List<KeyValuePair<int, int>> acceptedDimensions;
        private static String inputFolder = "";
        private static String outputFolder = "";

        public static String getOutputFolder()
        {
            return outputFolder;
        }
        public static void setOutputFolder(String folder)
        {
            outputFolder = folder;
        }

        public static String getInputFolder()
        {
            return inputFolder;
        }
        public static void setInputFolder(String folder)
        {
            inputFolder = folder;
        }

        public static void addDimension(KeyValuePair<int, int> dimension)
        {
            acceptedDimensions.Add(dimension);
        }

        public static List<KeyValuePair<int, int>> getDimensions()
        {
            return acceptedDimensions;
        }

    }
}

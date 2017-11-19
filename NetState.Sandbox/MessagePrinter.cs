using System;

namespace NetState.Sandbox {

    public static class MessagePrinter {

        private static void PrintSuccess(
            string message) {
            Console.ForegroundColor = ConsoleColor.Green;
            PrintMessageAndRestoreGrayForeground(message);
        }

        private static void PrintMessageAndRestoreGrayForeground(
            string message) {
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void PrintError(
            string message) {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintMessageAndRestoreGrayForeground(message);
        }

        private static void PrintNormal(
            string message) {
            Console.WriteLine(message);
        }

        public static void PrintAsSuccess(
            this string message) {
            PrintSuccess(message);
        }

        public static void PrintAsError(
            this string message) {
            PrintError(message);
        }

        public static void PrintAsNormal(
            this string message) {
            PrintNormal(message);
        }

    }

}
namespace jf
{
    class CustomError
    {
        private int lineNumber;
        private string message;

        public CustomError(int lineNumber, string message){
            this.lineNumber = lineNumber;
            this.message = message;
        }

        public int getLineNumber(){ return lineNumber; }
        public string getMessage(){ return message; }
    }
}

namespace NetState.Core.Barebones {

    public sealed class StatementProofResult {

        private StatementProofResult(
            bool success,
            string info) {
            Success = success;
            Info = info;
        }

        public bool Success { get; }

        public string Info { get; }

        public static StatementProofResult Successful() {
            return new StatementProofResult(
                true,
                string.Empty);
        }

        public static StatementProofResult Failed(
            string errorInfo) {
            return new StatementProofResult(
                false,
                errorInfo);
        }

    }

}
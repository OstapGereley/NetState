namespace NetState.Core.Barebones {

    public sealed class StatementEvaluationResult {

        private StatementEvaluationResult(bool success, string info) {
            Success = success;
            Info = info;
        }

        public bool Success { get; }

        public string Info { get; }

        public static StatementEvaluationResult Successful() {
            return new StatementEvaluationResult(true, string.Empty);
        }

        public static StatementEvaluationResult Failed(string errorInfo) {
            return new StatementEvaluationResult(false, errorInfo);
        }

    }

}
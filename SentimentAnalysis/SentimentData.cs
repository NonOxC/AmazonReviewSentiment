// <SnippetAddUsings>
using Microsoft.ML.Data;
// </SnippetAddUsings>

namespace SentimentAnalysis
{
    // <SnippetDeclareTypes>
    public class SentimentData
    {
        [LoadColumn(0), ColumnName("Label")] 
        public bool Sentiment { get; set; }

        [LoadColumn(1)] 
        public string Title { get; set; }

        [LoadColumn(2)] 
        public string SentimentText { get; set; }
    }

    public class SentimentPrediction : SentimentData
    {

        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }

        public float Probability { get; set; }

        public float Score { get; set; }
    }
    // </SnippetDeclareTypes>
}

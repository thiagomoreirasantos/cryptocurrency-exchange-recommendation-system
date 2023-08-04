using CryptoCurrencyRecommendations.Services.Dtos;

namespace CryptoCurrencyRecommendations.Api.Extensions
{
    public static class Mapper
    {
        public static Dtos.FeeEstimateOutput MapBTCToOutput(this BTCFeeEstimate feeEstimate) =>
            new()
            {
                HighFeePerKb = feeEstimate.HighFeePerKb,
                MediumFeePerKb = feeEstimate.MediumFeePerKb,
                LowFeePerKb = feeEstimate.LowFeePerKb
            };

        public static Dtos.FeeEstimateOutput MapETHToOutput(this ETHFeeEstimate feeEstimate) =>
        new()
        {
            HighFeePerKb = feeEstimate.HighPriorityFee,
            MediumFeePerKb = feeEstimate.MediumPriorityFee,
            LowFeePerKb = feeEstimate.LowPriorityFee
        };
    }
}
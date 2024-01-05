namespace RTCV.Launcher
{
    using System;

    internal class ExceptionHandler
    {
        static readonly string[] exceptionTable =
        {
            $"Error Code 0: RTCV cannot access the following filepath: [additionalInfo]. Please ensure that you have full read and write permissions to this location and try again.",
            "Error Code 1",
            "Error Code 2"
        };
        public static void CatchException(int errorCode, string additionalInfo, Exception ex)
        {
            throw new Exception(exceptionTable[errorCode].Replace("[additionalInfo]", additionalInfo), ex);
        }
    }
}

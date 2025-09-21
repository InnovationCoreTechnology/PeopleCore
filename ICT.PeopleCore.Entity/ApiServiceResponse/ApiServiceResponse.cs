namespace ICT.PeopleCore.Entity.ApiServiceResponse
{
    public class ApiServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; }
        public List<APIServicsMessage> Messages { get; set; } = new List<APIServicsMessage>();

        public class APIServicsMessage
        {
            public string Code { get; set; }
            public string Message { get; set; }
        }

        /// <summary>
        /// Success helper
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static ApiServiceResponse<T> SuccessResponse(T data, string code = CommonConstents.SUCCESS, string message = CommonConstents.REQUEST_COMPLETED_SUCCESSFULLY)
        {
            return new ApiServiceResponse<T>
            {
                Success = true,
                Data = data,
                Messages = new List<APIServicsMessage>
                {
                    new APIServicsMessage { Code = code, Message = message }
                }
            };
        }

        /// <summary>
        /// Failure helper
        /// </summary>
        /// <param name="message"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static ApiServiceResponse<T> FailureResponse(string code = CommonConstents.ERROR, string message = CommonConstents.REQUEST_FAILED)
        {
            return new ApiServiceResponse<T>
            {
                Success = false,
                Data = default,
                Messages = new List<APIServicsMessage>
                {
                    new APIServicsMessage { Code = code, Message = message }
                }
            };
        }
    }
}

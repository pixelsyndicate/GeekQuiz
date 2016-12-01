// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekQuiz.Models
{
    /// <summary>
    /// TriviaAnswer: represents the option selected by the user in response to a quiz question
    /// </summary>
    public class TriviaAnswer
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey("TriviaOption"), Column(Order = 1)]
        public int OptionId { get; set; }

        [ForeignKey("TriviaOption"), Column(Order = 0)]
        public int QuestionId { get; set; }

        [JsonIgnore]
        public virtual TriviaOption TriviaOption { get; set; }
    }
}
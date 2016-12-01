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

using System.Data.Entity;

namespace GeekQuiz.Models
{
    /// <summary>
    /// riviaContext: represents the Entity Framework's database context of the Geek Quiz application. 
    /// This class derives from DContext and exposes DbSet properties that represent collections of the entities TriviaOption, TriviaQuestion and TriviaAnswer.
    /// </summary>
    public class TriviaContext : DbContext
    {
        public TriviaContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<TriviaQuestion> TriviaQuestions { get; set; }
        public DbSet<TriviaOption> TriviaOptions { get; set; }
        public DbSet<TriviaAnswer> TriviaAnswers { get; set; }
    }
}
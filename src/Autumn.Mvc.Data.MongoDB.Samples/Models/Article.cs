﻿using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Autumn.Mvc.Data.MongoDB.Samples.Models
{
    [BsonIgnoreExtraElements]
    [AutumnEntity(Name = "articles", Version = "v1")]
    [AutumnIgnoreOperation(AutumnIgnoreOperationType.Insert | AutumnIgnoreOperationType.Update |
                           AutumnIgnoreOperationType.Delete)]
    public class Article : AbstractEntity
    {
        [Required]
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("content")]
        public string Content { get; set; }
    }

    [BsonIgnoreExtraElements]
    [AutumnEntity(Name = "articles", Version = "v2")]
    [AutumnIgnoreOperation(AutumnIgnoreOperationType.Insert)]
    public class ArticleV2 : Article
    {
        [BsonElement("publish_date")]
        public DateTime? PublishDate { get; set; }

        [Range(0, 100)]
        [BsonElement("score")]
        public int Score { get; set; }
    }
}
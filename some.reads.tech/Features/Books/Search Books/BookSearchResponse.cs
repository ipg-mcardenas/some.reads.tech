﻿using System.Text.Json.Serialization;

namespace some.reads.tech.Features.Books
{
    public record BookSearchResponse(
        string Title,
        string Key,
        [property: JsonPropertyName("author_name")] string[] AuthorName,
        [property: JsonPropertyName("cover_edition_key")] string CoverEditionKey,
        [property: JsonPropertyName("first_publish_year")] int FirstPublishYear
        );
}

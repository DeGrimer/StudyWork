﻿namespace StudyWork.Web.Infrastructure.Mappers
{
    public class FactUpdateViewModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
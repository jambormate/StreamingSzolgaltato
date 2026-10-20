using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingSzolgaltato
{
    internal class StreamingPlatform
    {
        public List<IContent> contents;

        public StreamingPlatform()
        {
            contents = new List<IContent>();
        }

        public void addContent(IContent content)
        {
            contents.Add(content);
        }

        public IContent getLongest()
        {
            if (contents.Count == 0)
            {
                return null;
            }

            IContent longest = contents[0];

            foreach (IContent content in contents)
            {
                if (content.getLength() > longest.getLength())
                {
                    longest = content;
                }
            }

            return longest;
        }
    }
}

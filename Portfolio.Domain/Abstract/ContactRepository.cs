﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Abstract
{
    public interface ContactRepository
    {
        Contact Contacts { get; }

        Contact SaveContact(Contact contact);
    }
}

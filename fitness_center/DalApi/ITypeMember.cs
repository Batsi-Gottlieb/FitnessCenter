﻿using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
   public interface ITypeMember
    {
        public List<TypeMember> Get();
    }
}

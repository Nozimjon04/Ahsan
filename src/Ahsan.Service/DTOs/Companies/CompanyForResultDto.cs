﻿using Ahsan.Service.DTOs.Users;

namespace Ahsan.Service.DTOs.Companies;

public class CompanyForResultDto
{
    public string Name { get; set; }
    public UserForResultDto Owner { get; set; }
}

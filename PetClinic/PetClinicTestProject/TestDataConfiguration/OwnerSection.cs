using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

public class OwnersSection {
    public List<OwnerConfiguration> OwnerList{get;}

    public OwnersSection(IConfiguration configuration) {
        configuration.GetSection("owners").Bind(OwnerList = new List<OwnerConfiguration>());
    }
}
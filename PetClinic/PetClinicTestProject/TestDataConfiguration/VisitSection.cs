using System.Collections.Generic;
using Microsoft.Extensions.Configuration;


namespace Name
{
    
}
public class VisitSection {
    public List<VisitConfiguration> Visits { get; }

    public VisitSection(IConfiguration configuration) {
        configuration.GetSection("visits").Bind(Visits = new List<VisitConfiguration>());
    }
}
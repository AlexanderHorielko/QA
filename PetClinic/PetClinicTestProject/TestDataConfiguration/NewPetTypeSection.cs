using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

public class NewPetTypeSection {
    public List<NewPetTypeConfiguration> PetTypes{get;}

    public NewPetTypeSection(IConfiguration configuration) {
        configuration.GetSection("petTypes").Bind(PetTypes = new List<NewPetTypeConfiguration>());
    }
}
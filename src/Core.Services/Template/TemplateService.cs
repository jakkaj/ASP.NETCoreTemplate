using System;
using System.Collections.Generic;
using System.Text;
using Core.Contracts.Template;
using Core.Models.Settings;
using Microsoft.Extensions.Options;

namespace Core.Services.Template
{
    public class TemplateService : ITemplateService
    {
        private readonly IOptions<CoreSettings> _settings;

        public TemplateService(IOptions<CoreSettings> settings)
        {
            _settings = settings;
        }
        public string DoSomething()
        {
            return _settings.Value.SettingSample;
        }
    }
}

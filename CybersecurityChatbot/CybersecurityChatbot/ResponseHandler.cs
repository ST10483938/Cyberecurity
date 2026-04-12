using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    internal class ResponseHandler
    {
        private readonly Dictionary<string, string> _responses = new()
        {
            {"password", "Use strong password with 12+ charecters, mixing letters, numbers, and symbols. Never reuse passwords across sites. Cnsider a password manager!" },
            {"phishing", "Phishing emails often fake trusted sender. Never click suspecious links. Always verify the sender's email address carefully." },
            {"browsing", "use HTTPS sites, avoid public WI-FI for sensitive tasks, and keep your browser updated to stay safe online." },
            {"malware", "Install reputable antivirus software, avoid downloading from unknown sources, and keep your OS updated to protect against malware" },
            {"vpn", "A VPN encrypts you intenet traffic, hiding your activity from hackers and your ISP - especially useful on piblic networks." },
            {"2fa", "Two-factor authentication adds an extra login step, making it much harder for attackers to access your accounts even with your password." },
            {"how are you", "I'm running securely, thank you! Ready to help you stay safe online." },
            {"purpose", "I'm here to raise cybersecurity awareness and help you stay protected in the digital world!"},
            {"what can i ask", "You can ask me about: passwords, phishing, safe browsing, malware, VPNs, and two-factor authentication (2FA)." },
        };

        public string GetResponse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null; //signals invalid input

            string lower = input.ToLower();

            foreach (var key in _responses.Keys)
            {
                
                if (lower.Contains(key))
                
                    return _responses[key];
                }
            
            return "I don't quite understand tha. could you rephase? Try asking about: passwords, phishing, browsing, malware, VPN, or 2FA.";
        }
    }
}

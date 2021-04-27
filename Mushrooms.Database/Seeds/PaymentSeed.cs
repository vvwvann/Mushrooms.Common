using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds
{
    public static class PaymentSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            var payments = new List<PaymentOption>
            {
                    new PaymentOption
                    {
                        Id = 1,
                        Index = 1,
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Credit card",
                            [LanguageType.DE] = "Credit card"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "The fastest and safest way of internet payment. Payment is processed with a system, trusted and recommended by Visa and MasterCard. It is not possible to charge your card offline / manual. You get an order confirmation e-mail, after payment was verified by your credit card provider.  All Credit Card payments will be administered by Wirecard CEE which is an official partner of VISA and MasterCard. Your data will be absolutely secure under a SSL coding of Wirecard CEE. For more information, visit: wirecard.at",
                            [LanguageType.DE] = "Die schnellste und sicherste Art der Internetzahlung. Die Zahlung erfolgt mit einem vertrauenswürdigen und von Visa und MasterCard empfohlenen System. Es ist nicht möglich, Ihre Karte offline / manuell aufzuladen. Sie erhalten eine Bestellbestätigungs-E-Mail, nachdem die Zahlung von Ihrem Kreditkartenanbieter überprüft wurde. Alle Kreditkartenzahlungen werden von Wirecard CEE verwaltet, einem offiziellen Partner von VISA und MasterCard. Ihre Daten sind unter einer SSL-Codierung von Wirecard CEE absolut sicher. Weitere Informationen finden Sie unter: wirecard.at",
                        }.ToJsonDocument(),
                        OrderDescription = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Visa, MasterCard, Maestro SecureCode",
                            [LanguageType.DE] = "Visa, MasterCard, Maestro SecureCode"
                        }.ToJsonDocument(),
                        Subtitle = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Visa, MasterCard, Maestro SecureCode",
                            [LanguageType.DE] = "Visa, MasterCard, Maestro SecureCode"
                        }.ToJsonDocument()
                    },
                    new PaymentOption
                    {
                        Id = 2,
                        Index = 2,
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Bank transfer",
                            [LanguageType.DE] = "Bank transfer"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "After your order was finished, you get an order confirmation e-mail with our bank data. Please transfer the total order amount in Euro to our bank account. Enter your order number in the field payment reference / reason for payment.",
                            [LanguageType.DE] = "Nach Abschluss Ihrer Bestellung erhalten Sie eine Bestellbestätigungs-E-Mail mit unseren Bankdaten. Bitte überweisen Sie den gesamten Bestellbetrag in Euro auf unser Bankkonto. Geben Sie Ihre Bestellnummer in das Feld Zahlungsreferenz / Zahlungsgrund ein.",
                        }.ToJsonDocument(),
                        OrderDescription = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "You transfer the invoice amount in advance payment.",
                            [LanguageType.DE] = "Sie überweisen den Rechnungsbetrag im Voraus."
                        }.ToJsonDocument()
                    },
                    new PaymentOption
                    {
                        Id = 3,
                        Index = 3,
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "SOFORT Banking",
                            [LanguageType.DE] = "SOFORT Banking"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "With SOFORT Banking you can pay easily and securely with your usual online banking login data. No registration required. More information at sofort.com! (Available already in Germany, Austria, Switzerland, Belgium, the Netherlands, Poland, and Italy.)",
                            [LanguageType.DE] = "Mit SOFORT Banking können Sie einfach und sicher mit Ihren üblichen Online-Banking-Anmeldedaten bezahlen. Keine Registrierung erforderlich. Weitere Informationen unter sofort.com! (Erhältlich bereits in Deutschland, Österreich, der Schweiz, Belgien, den Niederlanden, Polen und Italien.)",
                        }.ToJsonDocument(),
                        OrderDescription = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Online bank transfer without registration offering TÜV certified data privacy. Please keep your online banking data (PIN/TAN) ready.",
                            [LanguageType.DE] = "Sie überweisen den Rechnungsbetrag im Voraus."
                        }.ToJsonDocument(),
                        Subtitle = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Easy. Secure. Paid.",
                            [LanguageType.DE] = "Einfach. Sichern. Bezahlt."
                        }.ToJsonDocument()
                    },
                    new PaymentOption
                    {
                        Id = 4,
                        Index = 4,
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Cash on Delivery",
                            [LanguageType.DE] = "Cash on Delivery"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "You get an order confirmation e-mail with all needed information. Kindly send the total order amount in EURO, quoting your order number, as insured / registered letter (\"VALEUR DECLAREE\") to: MPC GmbH, Karmelitergasse 21, 6020 Innsbruck, AUSTRIA. For more information about sending cash with a letter, please call your local postal operator or ask at your next post office.",
                            [LanguageType.DE] = "Sie erhalten eine Bestellbestätigungs-E-Mail mit allen erforderlichen Informationen. Bitte senden Sie den Gesamtbestellbetrag in EURO unter Angabe Ihrer Bestellnummer als versicherten / eingeschriebenen Brief (\"VALEUR DECLAREE\") an: MPC GmbH, Karmelitergasse 21, 6020 Innsbruck, ÖSTERREICH. Für weitere Informationen zum Versenden von Bargeld mit einem Brief rufen Sie bitte Ihren örtlichen Postbetreiber an oder fragen Sie bei Ihrem nächsten Postamt nach.",
                        }.ToJsonDocument(),
                        OrderDescription = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Type of transaction in which the recipient makes payment for a good at the time of delivery",
                            [LanguageType.DE] = "Sie überweisen den Rechnungsbetrag im Voraus."
                        }.ToJsonDocument()
                    },
            };

            dbContext.PaymentOptions.AddOrUpdateRange(payments);
            dbContext.SaveChanges();
        }
    }
}



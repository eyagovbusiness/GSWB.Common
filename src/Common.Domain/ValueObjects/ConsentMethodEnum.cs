
namespace Common.Domain.ValueObjects
{
    public enum ConsentMethodEnum : byte
    {
        /// <summary>
        ///  User consents by clicking a button
        /// </summary>
        Button,
        /// <summary>
        /// Consent given through interaction with a cookie consent banner
        /// </summary>
        Banner,
        /// <summary>
        /// User consents by checking a checkbox.
        /// </summary>
        Checkbox,
        /// <summary>
        /// Consent given by submitting a form
        /// </summary>
        FormSubmission
    }
}

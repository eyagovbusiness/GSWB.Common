
namespace Common.Domain.ValueObjects
{
    public enum ConsentTypeEnum : byte
    {
        /// <summary>
        /// Direct, unambiguous consent (e.g., clicking an "I agree" button)
        /// </summary>
        Explicit,
        /// <summary>
        /// Consent inferred from actions (less common in strict GDPR compliance but may still be used in some contexts)
        /// </summary>
        //Implicit,
        /// <summary>
        /// User actively chooses to participate
        /// </summary>
        //OptIn,
        /// <summary>
        /// User actively chooses to not participate (important for certain types of data processing)
        /// </summary>
        //OptOut,
        /// <summary>
        /// User has been provided with sufficient information to make a knowledgeable decision.
        /// </summary>
        //Informed
    }
}

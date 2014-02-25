namespace NewsRotator
{
    /// <summary>
    /// Defines possible designs for the NewsRotator
    /// </summary>
    public enum RotatorDesign
    {
        /// <summary>
        /// Only the news articles' thumbnails are displayed.
        /// </summary>    
        ImageOnlyView,

        /// <summary>
        /// The thumbnail image is on the left side, text is on the right.
        /// </summary>
        LeftView,

        /// <summary>
        /// The thumbnail image is on the left side, text is on the right. Text background layer is transparent.
        /// </summary>
        LeftViewOverlay,

        /// <summary>
        /// The thumbnail image is on the right side, text is on the left.
        /// </summary>
        RightView,

        /// <summary>
        /// The thumbnail image is on the right side, text is on the left. Text background layer is transparent.
        /// </summary>
        RightViewOverlay,

        /// <summary>
        /// Both thumbnail and text are stretched out to 100% width.
        /// </summary>
        WideView,

        /// <summary>
        /// Both thumbnail and text are stretched out to 100% width. Text background layer is transparent.
        /// </summary>
        WideViewOverlay,

        /// <summary>
        /// Symbolizes a custom design setting. The template defined in TemplatePath is taken.
        /// </summary>
        Custom
    }
}

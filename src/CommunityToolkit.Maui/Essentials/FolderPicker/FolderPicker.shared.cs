using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Primitives;

namespace CommunityToolkit.Maui.Essentials;

/// <inheritdoc cref="IFolderPicker"/> 
public static class FolderPicker
{
	/// <summary>
	/// Allows picking a folder from the file system.
	/// </summary>
	/// <param name="initialPath">Initial path</param>
	/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
	/// <returns><see cref="Folder"/></returns>
	public static Task<Folder?> PickAsync(string initialPath, CancellationToken cancellationToken) =>
		Default.PickAsync(initialPath, cancellationToken);

	/// <summary>
	/// Allows picking a folder from the file system.
	/// </summary>
	/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
	/// <returns><see cref="Folder"/></returns>
	public static Task<Folder?> PickAsync(CancellationToken cancellationToken) =>
		Default.PickAsync(cancellationToken);

	static IFolderPicker? defaultImplementation;

	/// <summary>
	/// Default implementation to use
	/// </summary>
	public static IFolderPicker Default =>
		defaultImplementation ??= new FolderPickerImplementation();

	internal static void SetDefault(IFolderPicker? implementation) =>
		defaultImplementation = implementation;
}
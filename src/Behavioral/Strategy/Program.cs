/**
 * Strategy is a behavioral design pattern that
 * lets you define a family of algorithms,
 * put each of them into a separate class, and make their objects interchangeable.
 */

using Strategy.Compressor;
using Strategy.Filter;
using Strategy;

var imageStorage = new ImageStorage(
    compressor: new PngCompressor(),
    filter: new BlackAndWhiteFilter()
);

imageStorage.Store("a");

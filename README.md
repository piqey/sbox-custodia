## UPDATE: 5 June 2022
***Custodia is nowhere near complete (and hasn't been contributed to since last September).***

However, I, piqey (aka John Connor), do plan to return to this project, though the timing of this is uncertain. This could be today, tomorrow, or months from now, but I feel as though it will be one of the former, i.e., very soon. This would be the first milestone in my return to programming in s&box, something that has recently and spontaneously regained my interest for no discernable reason.

Until then, I am archiving this repository for the sake of cleanliness (and my own sanity by consequence).

# ![custodia](https://user-images.githubusercontent.com/12129071/134185493-55f2a6f6-f71a-462f-99e6-0a0ed1c3966c.png)

Custodia aims to be a robust and modular add-in administration framework for any of your s&amp;box projects whilst maintaining a relatively lightweight form factor that attempts to avoid giving any s&amp;devs unnecessary conniptions. It comes prepackaged, ready for use and structured with the streamlining of new updates in mind. I also intend to organize Custodia in a manner such that any repositories configured to automatically pull submodule updates will be able to do so without any complications.

<p align="center">
  <img src="https://img.shields.io/github/last-commit/piqey/sbox-custodia" />
  <img src="https://img.shields.io/github/stars/piqey/sbox-custodia" />
  <img src="https://img.shields.io/github/license/piqey/sbox-custodia" />
</p>

## Installation

To include this in your project, create a [git submodule](https://git-scm.com/docs/git-submodule) in your repository. The command you issue in your git repository's root folder should look something like this: `git submodule add https://github.com/piqey/sbox-custodia/code/Custodia/` (your capitalization of the letter "C" in "code" may vary). After taking care of adding the submodule, it can later be updated via the use of the `git submodule update` command.

Once you've taken care of that, the only required modification to make use of Custodia's features is that you derive your Game subclass from `Custodia.Game` (and ensure that you are calling its base methods in your overrides).

## Guide

If you've managed to progress far enough in s&box's API to have a use for this, you don't need me to tell you how it works (or how you can add features to it without touching the submodule files).

## Additional Notes

If you make a fork of this repository just to add features, I will be thoroughly disappointed. The entire objective in designing Custodia was and always will be to achieve legitimate modularity without the need for modifying Custodia itself; the vast majority of features one may be seeking to add to Custodia are likely achievable through one's own files in one's own repository (and a pinch of intuition).

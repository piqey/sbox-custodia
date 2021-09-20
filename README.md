# Custodia

Custodia aims to be a robust administration system add-in for any of your s&amp;box projects. It comes packaged ready for use without any extra baggage you don't want.

## Installation

To include this in your project, create a [git submodule](https://git-scm.com/docs/git-submodule) in your repository. This should look something like this: `git submodule add https://github.com/piqey/sbox-custodia code/Custodia/` (your capitalization of the C in "code" may vary). After taking care of adding the submodule, it can later be updated via the use of the `git submodule update` command.

Once you've taken care of that, all that is required on the C# side is that you derive your gamemode from `Custodia.Game` (and ensure that you are calling its base methods in your overrides).

## Guide

If you've managed to progress far enough in s&box's API to have a use for this, you don't need me to tell you how it works (or how you can add features to it without touching the submodule files).

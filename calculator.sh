#!/bin/sh
echo -ne '\033c\033]0;calculator\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/calculator.x86_64" "$@"

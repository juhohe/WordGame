info: Voikko-Dictionary-Format: 2

## Begin-Malaga-Configuration
info: Lex-Version: 3
info: Language-Code: fi_FI
info: Copyright: 2006-2014 Hannu Väisänen, Harri Pitkänen, Teemu Likonen and others
info: License: GPL version 2 or later
info: Language-Variant: morpho
info: Description: suomi, erittäin laaja sanasto (mukana myös morfologisessa analyysissä tarvittava lisäinformaatio)
info: SM-Version: 1.16
info: SM-Patchinfo: Development snapshot
info: Build-Config: GENLEX_OPTS=--extra-usage=it,science,medicine,education,orgname --style=dialect,old,international,foreign,inappropriate --min-frequency=10 EXTRA_LEX=vocabulary/erikoisalat/science-misc.lex vocabulary/erikoisalat/atk-lyhenteet.lex vocabulary/erikoisalat/linux-distributions.lex
info: Build-Date: Sat, 08 Mar 2014 07:15:59 +0000
## End-Malaga-Configuration

## Begin-User-Configuration
lex: voikko-fi_FI.lex suomi.lex
lex: main.lex
mallex: set switch vanhahkot_muodot yes
mallex: set switch vanhat_muodot yes
mallex: set switch sukijan_muodot no
## End-User-Configuration

## Begin-Internal-Configuration
sym: voikko-fi_FI.sym
all: voikko-fi_FI.all suomi.inc subrule.inc config.inc voikko-fi_FI.pro
lex: suomi.inc subrule.inc voikko-fi_FI.pro
lex: erikoissanat.lex
lex: seikkasanat.lex
lex: suhdesanat.lex
lex: lukusanat.lex
lex: lyhenteet.lex
lex: olla-ei.lex
lex: yhdyssanat.lex
lex: erikoiset.lex
lex: poikkeavat.lex
lex: lainen.lex
lex: taivutustaydennykset.lex
mor: voikko-fi_FI.mor suomi.inc mor.inc subrule.inc config.inc
malaga: set display-line "malshow"
mallex: set display-line "malshow"
mallex: set use-display yes
malaga: set use-display yes
malaga: set mor-pruning 30
mallex: set switch voikko_murre yes
malaga: set mor-incomplete no
## End-Internal-Configuration


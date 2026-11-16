using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_06 : CardInfo
{
    public CardInfo_191_JA_06()
    {
        this.cardNo = "191_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ÉJÉãÉzÅ[Éì";
        this.cardName2 = "äCï∫ë‡åRëÇ";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

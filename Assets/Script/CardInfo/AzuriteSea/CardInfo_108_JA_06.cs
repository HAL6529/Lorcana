using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_06 : CardInfo
{
    public CardInfo_108_JA_06()
    {
        this.cardNo = "108_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ウェンディ・ダーリング";
        this.cardName2 = "いさまし船長";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagnoAndMarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

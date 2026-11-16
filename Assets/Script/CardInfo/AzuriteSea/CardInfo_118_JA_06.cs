using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_06 : CardInfo
{
    public CardInfo_118_JA_06()
    {
        this.cardNo = "118_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジョン・ダーリング";
        this.cardName2 = "こなれた剣士";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

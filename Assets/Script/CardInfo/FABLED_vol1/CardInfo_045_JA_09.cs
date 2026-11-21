using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_09 : CardInfo
{
    public CardInfo_045_JA_09()
    {
        this.cardNo = "045_JA_09";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ダンボ";
        this.cardName2 = "世界の七不思議";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Dumbo;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

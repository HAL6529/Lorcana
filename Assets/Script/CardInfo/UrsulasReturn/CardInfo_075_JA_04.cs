using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_04 : CardInfo
{
    public CardInfo_075_JA_04()
    {
        this.cardNo = "075_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ヘイヘイ";
        this.cardName2 = "トンマなニワトリ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AnnaStosik;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

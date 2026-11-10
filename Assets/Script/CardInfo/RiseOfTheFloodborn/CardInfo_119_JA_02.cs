using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_119_JA_02 : CardInfo
{
    public CardInfo_119_JA_02()
    {
        this.cardNo = "119_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ハートの女王";
        this.cardName2 = "衝動的な支配者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

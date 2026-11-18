using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_08 : CardInfo
{
    public CardInfo_025_JA_08()
    {
        this.cardNo = "025_JA_08";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "パッチ";
        this.cardName2 = "いたずら好きな子犬";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

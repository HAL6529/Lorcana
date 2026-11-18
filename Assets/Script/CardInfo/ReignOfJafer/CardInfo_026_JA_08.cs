using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_026_JA_08 : CardInfo
{
    public CardInfo_026_JA_08()
    {
        this.cardNo = "026_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ローリー";
        this.cardName2 = "ぽっちゃりわんちゃん";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

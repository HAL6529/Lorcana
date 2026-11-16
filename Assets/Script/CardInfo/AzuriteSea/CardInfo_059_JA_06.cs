using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_06 : CardInfo
{
    public CardInfo_059_JA_06()
    {
        this.cardNo = "059_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マッドハッター";
        this.cardName2 = "突飛な主催者";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

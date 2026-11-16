using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_06 : CardInfo
{
    public CardInfo_046_JA_06()
    {
        this.cardNo = "046_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "セイウチ";
        this.cardName2 = "よくカキ食う客";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosLuzzi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

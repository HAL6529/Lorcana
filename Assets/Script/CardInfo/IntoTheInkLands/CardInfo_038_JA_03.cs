using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_03 : CardInfo
{
    public CardInfo_038_JA_03()
    {
        this.cardNo = "038_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ジーニー";
        this.cardName2 = "頼れる友だち";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

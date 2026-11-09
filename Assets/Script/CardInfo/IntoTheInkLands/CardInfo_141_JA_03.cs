using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_03 : CardInfo
{
    public CardInfo_141_JA_03()
    {
        this.cardNo = "141_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジーニー";
        this.cardName2 = "狭いランプからコンニチワ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlibethZermeno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

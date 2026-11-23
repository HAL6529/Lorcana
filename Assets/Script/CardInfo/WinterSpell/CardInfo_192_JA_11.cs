using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_11 : CardInfo
{
    public CardInfo_192_JA_11()
    {
        this.cardNo = "192_JA_11";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ダークウィング・ダック";
        this.cardName2 = "プレッシャーにもクールな硬すぎアイスのような男！";
        this.power = 6;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}

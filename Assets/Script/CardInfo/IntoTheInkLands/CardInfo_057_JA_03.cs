using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_03 : CardInfo
{
    public CardInfo_057_JA_03()
    {
        this.cardNo = "057_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "èóâ§";
        this.cardName2 = "ëûà´Ç…îRÇ¶ÇΩèhìG";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AnnaRudAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}

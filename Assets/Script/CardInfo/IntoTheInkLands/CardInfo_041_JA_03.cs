using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_041_JA_03 : CardInfo
{
    public CardInfo_041_JA_03()
    {
        this.cardNo = "041_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジャファー";
        this.cardName2 = "ランプ泥棒";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_02 : CardInfo
{
    public CardInfo_013_JA_02()
    {
        this.cardNo = "013_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "陽気なお出むかえ";
        this.power = 1;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

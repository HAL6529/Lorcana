using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_13 : CardInfo
{
    public CardInfo_033_JA_13()
    {
        this.cardNo = "033_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "本当の自分を隠さないで";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}

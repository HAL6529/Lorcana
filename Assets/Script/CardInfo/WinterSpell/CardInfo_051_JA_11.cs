using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_11 : CardInfo
{
    public CardInfo_051_JA_11()
    {
        this.cardNo = "051_JA_11";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "クリストフ";
        this.cardName2 = "氷原の探検家";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}

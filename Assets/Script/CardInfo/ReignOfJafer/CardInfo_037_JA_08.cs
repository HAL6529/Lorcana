using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_08 : CardInfo
{
    public CardInfo_037_JA_08()
    {
        this.cardNo = "037_JA_08";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "コイン収集家";
        this.power = 4;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RiantiHidayat;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_08 : CardInfo
{
    public CardInfo_074_JA_08()
    {
        this.cardNo = "074_JA_08";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ジャファー";
        this.cardName2 = "ロルカナの大サルタン";
        this.power = 4;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JohnLorenAndCristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

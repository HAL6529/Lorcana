using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_06 : CardInfo
{
    public CardInfo_193_JA_06()
    {
        this.cardNo = "193_JA_06";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ジャファー";
        this.cardName2 = "力に飢えた大臣";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_06 : CardInfo
{
    public CardInfo_175_JA_06()
    {
        this.cardNo = "175_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ミスター・スミー";
        this.cardName2 = "忠義深いお仲間";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosLuzzi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}

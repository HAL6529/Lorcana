using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_189_JA_06 : CardInfo
{
    public CardInfo_189_JA_06()
    {
        this.cardNo = "189_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒKƒ“ƒgƒD";
        this.cardName2 = "‚Â‚Þ‚¶‹È‚ª‚è‚Ì‘åˆÑ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Alien, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
